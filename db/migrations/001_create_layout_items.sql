-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, region, rank, count) VALUES ('fallback', 'blue', 63, 85);
INSERT INTO layout_items (label, region, rank, count) VALUES ('edge', 'green', 65, 7);
INSERT INTO layout_items (label, region, rank, count) VALUES ('latest', 'stable', 28, 84);
