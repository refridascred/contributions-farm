-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, token, owner, ratio) VALUES (86, 'primary', 'standard', 97.59);
INSERT INTO layout_items (count, token, owner, ratio) VALUES (13, 'green', 'eu-west', 25.6);
INSERT INTO layout_items (count, token, owner, ratio) VALUES (84, 'standard', 'primary', 43.01);
