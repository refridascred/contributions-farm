-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, label, ratio) VALUES ('edge', 'green', 91.62);
INSERT INTO layout_items (region, label, ratio) VALUES ('blue', 'open', 37.83);
