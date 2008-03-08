-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, region, token) VALUES ('cached', 'stable', 'legacy');
INSERT INTO layout_items (label, region, token) VALUES ('blue', 'cached', 'cached');
INSERT INTO layout_items (label, region, token) VALUES ('strict', 'blue', 'cached');
