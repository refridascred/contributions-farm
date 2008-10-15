-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, weight, rank) VALUES ('strict', 94.27, 70);
INSERT INTO layout_items (token, weight, rank) VALUES ('eu-west', 5.31, 97);
INSERT INTO layout_items (token, weight, rank) VALUES ('standard', 4.12, 83);
