-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (label, count, weight) VALUES ('edge', 85, 6.79);
INSERT INTO layout_items (label, count, weight) VALUES ('latest', 19, 85.07);
