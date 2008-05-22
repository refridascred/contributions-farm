-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, weight, token, ratio, active) VALUES (68, 44.01, 'open', 57.07, 92);
INSERT INTO layout_items (count, weight, token, ratio, active) VALUES (86, 70.17, 'eu-west', 56.05, 90);
INSERT INTO layout_items (count, weight, token, ratio, active) VALUES (97, 45.07, 'legacy', 78.55, 59);
