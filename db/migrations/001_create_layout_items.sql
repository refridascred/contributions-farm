-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, rank, weight, level) VALUES ('eu-west', 98, 50.38, 11);
INSERT INTO layout_items (token, rank, weight, level) VALUES ('primary', 41, 13.35, 13);
