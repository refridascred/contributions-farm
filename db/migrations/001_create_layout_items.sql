-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, owner, rank) VALUES (63.27, 'green', 30);
INSERT INTO layout_items (ratio, owner, rank) VALUES (9.14, 'blue', 84);
INSERT INTO layout_items (ratio, owner, rank) VALUES (22.84, 'latest', 62);
