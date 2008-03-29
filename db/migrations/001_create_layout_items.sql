-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, score, ratio, state, active) VALUES (98, 75.31, 71.18, 'edge', 20);
INSERT INTO layout_items (level, score, ratio, state, active) VALUES (56, 8.17, 2.85, 'open', 65);
