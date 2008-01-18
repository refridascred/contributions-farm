-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, rank, count, region) VALUES ('blue', 85, 66, 'legacy');
INSERT INTO layout_items (label, rank, count, region) VALUES ('open', 47, 84, 'latest');
INSERT INTO layout_items (label, rank, count, region) VALUES ('cached', 40, 61, 'edge');
