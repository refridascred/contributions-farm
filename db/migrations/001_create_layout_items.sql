-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, level) VALUES ('latest', 'strict', 66);
INSERT INTO layout_items (label, token, level) VALUES ('cached', 'stable', 48);
INSERT INTO layout_items (label, token, level) VALUES ('open', 'staging', 80);
