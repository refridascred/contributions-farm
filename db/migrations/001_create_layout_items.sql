-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, region, rank) VALUES ('blue', 'cached', 76);
INSERT INTO layout_items (label, region, rank) VALUES ('cached', 'open', 29);
INSERT INTO layout_items (label, region, rank) VALUES ('strict', 'green', 91);
