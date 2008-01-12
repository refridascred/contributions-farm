-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (score, rank, token, weight) VALUES (19.89, 95, 'eu-west', 5.52);
INSERT INTO layout_items (score, rank, token, weight) VALUES (0.27, 52, 'open', 6.97);
INSERT INTO layout_items (score, rank, token, weight) VALUES (79.21, 96, 'open', 37.01);
