-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, token, level) VALUES ('latest', 'strict', 36);
INSERT INTO layout_items (label, token, level) VALUES ('eu-west', 'blue', 76);
INSERT INTO layout_items (label, token, level) VALUES ('cached', 'latest', 59);
