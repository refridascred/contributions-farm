-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, rank, label, token, region) VALUES (73, 3, 'strict', 'local', 'edge');
INSERT INTO layout_items (count, rank, label, token, region) VALUES (54, 6, 'standard', 'latest', 'cached');
INSERT INTO layout_items (count, rank, label, token, region) VALUES (39, 86, 'blue', 'blue', 'standard');
