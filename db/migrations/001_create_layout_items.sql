-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, label, ratio) VALUES ('eu-west', 'green', 85.39);
INSERT INTO layout_items (token, label, ratio) VALUES ('local', 'latest', 61.18);
INSERT INTO layout_items (token, label, ratio) VALUES ('staging', 'local', 2.27);
