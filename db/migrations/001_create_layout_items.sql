-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, rank, ratio, count) VALUES ('eu-west', 58, 51.75, 51);
INSERT INTO layout_items (label, rank, ratio, count) VALUES ('strict', 26, 57.15, 52);
INSERT INTO layout_items (label, rank, ratio, count) VALUES ('open', 93, 65.59, 28);
