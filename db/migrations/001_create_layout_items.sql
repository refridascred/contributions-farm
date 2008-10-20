-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, label, token, owner) VALUES (1.68, 'eu-west', 'cached', 'edge');
INSERT INTO layout_items (ratio, label, token, owner) VALUES (58.19, 'blue', 'cached', 'green');
INSERT INTO layout_items (ratio, label, token, owner) VALUES (65.11, 'fallback', 'green', 'standard');
