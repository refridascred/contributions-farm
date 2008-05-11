-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, label, level) VALUES (47.2, 'open', 74);
INSERT INTO layout_items (ratio, label, level) VALUES (24.61, 'primary', 92);
INSERT INTO layout_items (ratio, label, level) VALUES (11.42, 'legacy', 71);
