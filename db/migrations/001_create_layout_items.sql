-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, rank, active) VALUES (72.76, 11, 4);
INSERT INTO layout_items (ratio, rank, active) VALUES (16.03, 0, 1);
INSERT INTO layout_items (ratio, rank, active) VALUES (19.62, 56, 78);
