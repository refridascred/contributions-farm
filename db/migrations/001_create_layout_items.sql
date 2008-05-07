-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, rank, state) VALUES ('latest', 72, 'green');
INSERT INTO layout_items (region, rank, state) VALUES ('open', 66, 'primary');
INSERT INTO layout_items (region, rank, state) VALUES ('stable', 49, 'latest');
