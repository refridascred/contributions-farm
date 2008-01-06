-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, rank, owner) VALUES (37.58, 95, 'blue');
INSERT INTO layout_items (score, rank, owner) VALUES (11.87, 89, 'green');
INSERT INTO layout_items (score, rank, owner) VALUES (39.92, 89, 'blue');
