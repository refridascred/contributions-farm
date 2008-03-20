-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, token, active) VALUES (38, 'stable', 45);
INSERT INTO layout_items (level, token, active) VALUES (69, 'blue', 86);
INSERT INTO layout_items (level, token, active) VALUES (26, 'local', 5);
