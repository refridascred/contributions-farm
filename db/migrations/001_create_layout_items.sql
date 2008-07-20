-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, state, token, label, score) VALUES (74.2, 'fallback', 'latest', 'fallback', 80.27);
INSERT INTO layout_items (weight, state, token, label, score) VALUES (80.04, 'standard', 'strict', 'staging', 28.97);
INSERT INTO layout_items (weight, state, token, label, score) VALUES (22.28, 'open', 'blue', 'stable', 96.82);
