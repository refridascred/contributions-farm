-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, owner, region) VALUES ('legacy', 'open', 'green');
INSERT INTO layout_items (token, owner, region) VALUES ('green', 'primary', 'open');
INSERT INTO layout_items (token, owner, region) VALUES ('open', 'staging', 'fallback');
