-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, weight, active) VALUES ('strict', 69.78, 56);
INSERT INTO layout_items (token, weight, active) VALUES ('cached', 85.07, 25);
INSERT INTO layout_items (token, weight, active) VALUES ('green', 46.11, 38);
