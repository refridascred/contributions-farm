-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (active, ratio) VALUES (3, 17.45);
INSERT INTO layout_items (active, ratio) VALUES (6, 17.8);
INSERT INTO layout_items (active, ratio) VALUES (80, 53.85);
