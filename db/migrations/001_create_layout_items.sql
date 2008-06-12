-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, active, score) VALUES (33.45, 94, 56.26);
INSERT INTO layout_items (ratio, active, score) VALUES (10.02, 93, 75.54);
INSERT INTO layout_items (ratio, active, score) VALUES (12.41, 61, 51.38);
