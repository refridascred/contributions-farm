-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, label, score) VALUES (81.69, 'cached', 56.15);
INSERT INTO layout_items (ratio, label, score) VALUES (11.81, 'legacy', 69.91);
INSERT INTO layout_items (ratio, label, score) VALUES (8.39, 'open', 41.53);
