-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, rank, token, active) VALUES ('legacy', 30, 'latest', 31);
INSERT INTO layout_items (region, rank, token, active) VALUES ('strict', 76, 'cached', 12);
INSERT INTO layout_items (region, rank, token, active) VALUES ('standard', 82, 'open', 51);
