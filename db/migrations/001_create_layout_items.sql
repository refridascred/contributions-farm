-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, state, score, rank) VALUES (38.56, 'edge', 3.22, 63);
INSERT INTO layout_items (weight, state, score, rank) VALUES (17.83, 'open', 48.41, 40);
INSERT INTO layout_items (weight, state, score, rank) VALUES (67.84, 'local', 59.39, 15);
