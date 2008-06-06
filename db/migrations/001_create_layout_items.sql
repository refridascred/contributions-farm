-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, state, weight, score, active) VALUES (60, 'edge', 60.51, 0.58, 39);
INSERT INTO layout_items (level, state, weight, score, active) VALUES (38, 'edge', 12.01, 72.53, 52);
INSERT INTO layout_items (level, state, weight, score, active) VALUES (78, 'eu-west', 8.04, 35.31, 19);
