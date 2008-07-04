-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, region, count, ratio) VALUES ('standard', 'latest', 81, 73.26);
INSERT INTO layout_items (label, region, count, ratio) VALUES ('cached', 'primary', 53, 63.53);
