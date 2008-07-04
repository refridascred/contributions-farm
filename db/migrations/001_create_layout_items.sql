-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, token, ratio) VALUES ('local', 'blue', 91.1);
INSERT INTO layout_items (owner, token, ratio) VALUES ('cached', 'primary', 1.8);
