-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, rank, label) VALUES ('stable', 31, 'legacy');
INSERT INTO layout_items (region, rank, label) VALUES ('staging', 2, 'open');
