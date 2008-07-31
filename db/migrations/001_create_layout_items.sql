-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (owner, rank) VALUES ('eu-west', 83);
INSERT INTO layout_items (owner, rank) VALUES ('primary', 32);
INSERT INTO layout_items (owner, rank) VALUES ('stable', 49);
