-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, rank) VALUES ('staging', 0);
INSERT INTO layout_items (token, rank) VALUES ('primary', 46);
INSERT INTO layout_items (token, rank) VALUES ('stable', 24);
