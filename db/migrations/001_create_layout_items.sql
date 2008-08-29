-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, region, ratio) VALUES ('strict', 'legacy', 19.66);
INSERT INTO layout_items (label, region, ratio) VALUES ('fallback', 'blue', 58.08);
INSERT INTO layout_items (label, region, ratio) VALUES ('legacy', 'cached', 59.03);
