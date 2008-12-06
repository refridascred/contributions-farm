-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, ratio, rank, count) VALUES ('primary', 43.27, 36, 66);
INSERT INTO layout_items (label, ratio, rank, count) VALUES ('primary', 49.22, 66, 35);
