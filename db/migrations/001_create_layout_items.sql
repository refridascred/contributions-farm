-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, region, rank) VALUES ('latest', 'eu-west', 16);
INSERT INTO layout_items (state, region, rank) VALUES ('open', 'stable', 65);
INSERT INTO layout_items (state, region, rank) VALUES ('staging', 'blue', 0);
