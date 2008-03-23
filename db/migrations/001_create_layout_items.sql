-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, weight, owner) VALUES (10.67, 74.85, 'edge');
INSERT INTO layout_items (score, weight, owner) VALUES (23.69, 81.49, 'local');
