-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, count, ratio) VALUES ('edge', 47, 83.46);
INSERT INTO layout_items (label, count, ratio) VALUES ('open', 10, 77.84);
INSERT INTO layout_items (label, count, ratio) VALUES ('standard', 90, 69.27);
