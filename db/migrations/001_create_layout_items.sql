-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, active, owner, ratio) VALUES ('cached', 62.0, 67, 'standard', 14.92);
INSERT INTO layout_items (token, weight, active, owner, ratio) VALUES ('legacy', 92.33, 0, 'green', 62.68);
