-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, region, label, weight) VALUES (53, 'staging', 'cached', 24.1);
INSERT INTO layout_items (count, region, label, weight) VALUES (3, 'staging', 'blue', 91.73);
