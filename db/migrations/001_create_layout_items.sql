-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, rank, ratio) VALUES (13, 34, 61.94);
INSERT INTO layout_items (active, rank, ratio) VALUES (72, 45, 84.17);
INSERT INTO layout_items (active, rank, ratio) VALUES (67, 29, 18.11);
