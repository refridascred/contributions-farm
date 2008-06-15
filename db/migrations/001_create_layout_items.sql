-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, label, ratio) VALUES (94, 'eu-west', 19.37);
INSERT INTO layout_items (count, label, ratio) VALUES (65, 'edge', 15.2);
INSERT INTO layout_items (count, label, ratio) VALUES (83, 'strict', 36.38);
