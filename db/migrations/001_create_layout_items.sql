-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, count, active, rank, label) VALUES (41.55, 90, 76, 68, 'open');
INSERT INTO layout_items (ratio, count, active, rank, label) VALUES (10.3, 63, 85, 75, 'latest');
INSERT INTO layout_items (ratio, count, active, rank, label) VALUES (96.54, 40, 4, 43, 'open');
