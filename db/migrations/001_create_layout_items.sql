-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, label, owner) VALUES ('primary', 'green', 'standard');
INSERT INTO layout_items (token, label, owner) VALUES ('open', 'stable', 'staging');
INSERT INTO layout_items (token, label, owner) VALUES ('open', 'primary', 'standard');
