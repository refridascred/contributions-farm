-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, rank, label, level) VALUES ('eu-west', 35, 'cached', 46);
INSERT INTO layout_items (region, rank, label, level) VALUES ('staging', 96, 'cached', 62);
INSERT INTO layout_items (region, rank, label, level) VALUES ('green', 17, 'open', 66);
