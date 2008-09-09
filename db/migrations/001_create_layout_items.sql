-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, label, owner, ratio) VALUES (25, 'blue', 'edge', 20.73);
INSERT INTO layout_items (count, label, owner, ratio) VALUES (44, 'cached', 'green', 13.56);
