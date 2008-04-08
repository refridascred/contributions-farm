-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, rank, active) VALUES ('legacy', 23, 78);
INSERT INTO layout_items (region, rank, active) VALUES ('cached', 92, 5);
INSERT INTO layout_items (region, rank, active) VALUES ('standard', 46, 62);
