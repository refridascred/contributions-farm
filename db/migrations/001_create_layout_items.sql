-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, label, owner, weight) VALUES ('edge', 'green', 'strict', 57.3);
INSERT INTO layout_items (region, label, owner, weight) VALUES ('stable', 'open', 'cached', 58.3);
