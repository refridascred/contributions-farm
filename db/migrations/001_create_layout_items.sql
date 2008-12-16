-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, level, label) VALUES ('legacy', 60, 'strict');
INSERT INTO layout_items (region, level, label) VALUES ('fallback', 7, 'legacy');
