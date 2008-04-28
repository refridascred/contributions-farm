-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, token, weight) VALUES (66, 'legacy', 90.9);
INSERT INTO layout_items (active, token, weight) VALUES (84, 'staging', 53.44);
INSERT INTO layout_items (active, token, weight) VALUES (71, 'latest', 53.94);
