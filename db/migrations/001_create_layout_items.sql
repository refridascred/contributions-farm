-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, ratio, rank, count, active) VALUES ('staging', 29.31, 40, 93, 21);
INSERT INTO layout_items (label, ratio, rank, count, active) VALUES ('fallback', 55.91, 99, 24, 98);
INSERT INTO layout_items (label, ratio, rank, count, active) VALUES ('primary', 43.66, 54, 86, 36);
