-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, level, owner) VALUES ('eu-west', 82, 'staging');
INSERT INTO layout_items (token, level, owner) VALUES ('cached', 43, 'eu-west');
INSERT INTO layout_items (token, level, owner) VALUES ('blue', 37, 'strict');
