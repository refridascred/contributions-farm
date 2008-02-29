-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, token, region, rank) VALUES ('latest', 'stable', 'fallback', 54);
INSERT INTO layout_items (label, token, region, rank) VALUES ('latest', 'cached', 'standard', 30);
