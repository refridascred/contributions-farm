-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, score, state, label) VALUES (47, 53.39, 'blue', 'open');
INSERT INTO layout_items (level, score, state, label) VALUES (16, 45.65, 'strict', 'open');
INSERT INTO layout_items (level, score, state, label) VALUES (2, 93.36, 'primary', 'stable');
