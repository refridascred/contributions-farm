-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, rank, ratio, weight) VALUES (12, 79, 52.75, 36.3);
INSERT INTO layout_items (active, rank, ratio, weight) VALUES (53, 24, 9.08, 21.4);
