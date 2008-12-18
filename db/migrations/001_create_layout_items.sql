-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, state) VALUES ('legacy', 86.9, 'legacy');
INSERT INTO layout_items (region, ratio, state) VALUES ('strict', 1.05, 'green');
