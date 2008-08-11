-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, state, score, active) VALUES (17.42, 'edge', 37.69, 65);
INSERT INTO layout_items (ratio, state, score, active) VALUES (92.26, 'edge', 79.81, 84);
INSERT INTO layout_items (ratio, state, score, active) VALUES (70.95, 'cached', 20.95, 56);
