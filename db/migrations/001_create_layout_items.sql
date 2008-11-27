-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, count, ratio) VALUES ('primary', 19, 0.57);
INSERT INTO layout_items (label, count, ratio) VALUES ('cached', 21, 62.43);
INSERT INTO layout_items (label, count, ratio) VALUES ('staging', 99, 8.35);
