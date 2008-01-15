-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, label, level) VALUES (74.57, 'strict', 48);
INSERT INTO layout_items (score, label, level) VALUES (93.51, 'local', 69);
INSERT INTO layout_items (score, label, level) VALUES (32.32, 'eu-west', 71);
