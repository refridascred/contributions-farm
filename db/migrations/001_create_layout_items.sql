-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, region, ratio) VALUES ('legacy', 'stable', 17.91);
INSERT INTO layout_items (owner, region, ratio) VALUES ('strict', 'strict', 43.21);
INSERT INTO layout_items (owner, region, ratio) VALUES ('staging', 'blue', 29.28);
